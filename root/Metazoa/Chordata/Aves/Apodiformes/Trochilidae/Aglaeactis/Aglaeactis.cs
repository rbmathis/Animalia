using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Aglaeactis;

/// <summary>
/// Abstract class for Aglaeactis (genus).
/// NCBI TaxId: 56647
/// </summary>
public abstract class Aglaeactis : Trochilidae, IAglaeactis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aglaeactis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56647;

    /// <inheritdoc />
    public virtual string GenusName => "Aglaeactis";

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
