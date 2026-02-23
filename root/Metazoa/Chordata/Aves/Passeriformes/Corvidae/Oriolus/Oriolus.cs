using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Oriolus;

/// <summary>
/// Abstract class for Oriolus (genus).
/// NCBI TaxId: 98139
/// </summary>
public abstract class Oriolus : Corvidae, IOriolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oriolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98139;

    /// <inheritdoc />
    public virtual string GenusName => "Oriolus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
