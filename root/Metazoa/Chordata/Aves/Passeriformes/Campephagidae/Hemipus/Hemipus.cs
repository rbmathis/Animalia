using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Hemipus;

/// <summary>
/// Abstract class for Hemipus (genus).
/// NCBI TaxId: 370839
/// </summary>
public abstract class Hemipus : Campephagidae, IHemipus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemipus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 370839;

    /// <inheritdoc />
    public virtual string GenusName => "Hemipus";

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
