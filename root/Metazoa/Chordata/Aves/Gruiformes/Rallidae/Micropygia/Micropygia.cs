using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Micropygia;

/// <summary>
/// Abstract class for Micropygia (genus).
/// NCBI TaxId: 1118750
/// </summary>
public abstract class Micropygia : Rallidae, IMicropygia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micropygia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1118750;

    /// <inheritdoc />
    public virtual string GenusName => "Micropygia";

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
