using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Lobotos;

/// <summary>
/// Abstract class for Lobotos (genus).
/// NCBI TaxId: 880553
/// </summary>
public abstract class Lobotos : Campephagidae, ILobotos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lobotos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 880553;

    /// <inheritdoc />
    public virtual string GenusName => "Lobotos";

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
