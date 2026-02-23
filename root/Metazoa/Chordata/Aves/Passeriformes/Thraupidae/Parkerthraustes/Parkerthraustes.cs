using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Parkerthraustes;

/// <summary>
/// Abstract class for Parkerthraustes (genus).
/// NCBI TaxId: 460194
/// </summary>
public abstract class Parkerthraustes : Thraupidae, IParkerthraustes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parkerthraustes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 460194;

    /// <inheritdoc />
    public virtual string GenusName => "Parkerthraustes";

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
