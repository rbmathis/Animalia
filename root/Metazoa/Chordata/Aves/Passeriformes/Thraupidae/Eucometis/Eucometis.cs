using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Eucometis;

/// <summary>
/// Abstract class for Eucometis (genus).
/// NCBI TaxId: 62196
/// </summary>
public abstract class Eucometis : Thraupidae, IEucometis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eucometis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62196;

    /// <inheritdoc />
    public virtual string GenusName => "Eucometis";

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
