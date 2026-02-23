using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Catamblyrhynchus;

/// <summary>
/// Abstract class for Catamblyrhynchus (genus).
/// NCBI TaxId: 194940
/// </summary>
public abstract class Catamblyrhynchus : Thraupidae, ICatamblyrhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Catamblyrhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 194940;

    /// <inheritdoc />
    public virtual string GenusName => "Catamblyrhynchus";

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
