using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Coryphaspiza;

/// <summary>
/// Abstract class for Coryphaspiza (genus).
/// NCBI TaxId: 1226229
/// </summary>
public abstract class Coryphaspiza : Thraupidae, ICoryphaspiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coryphaspiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1226229;

    /// <inheritdoc />
    public virtual string GenusName => "Coryphaspiza";

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
