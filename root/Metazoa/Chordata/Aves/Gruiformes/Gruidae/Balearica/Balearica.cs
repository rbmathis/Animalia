using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Balearica;

/// <summary>
/// Abstract class for Balearica (genus).
/// NCBI TaxId: 30413
/// </summary>
public abstract class Balearica : Gruidae, IBalearica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Balearica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30413;

    /// <inheritdoc />
    public virtual string GenusName => "Balearica";

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
