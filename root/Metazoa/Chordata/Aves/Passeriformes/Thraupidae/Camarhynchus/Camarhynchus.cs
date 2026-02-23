using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Camarhynchus;

/// <summary>
/// Abstract class for Camarhynchus (genus).
/// NCBI TaxId: 87174
/// </summary>
public abstract class Camarhynchus : Thraupidae, ICamarhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Camarhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 87174;

    /// <inheritdoc />
    public virtual string GenusName => "Camarhynchus";

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
