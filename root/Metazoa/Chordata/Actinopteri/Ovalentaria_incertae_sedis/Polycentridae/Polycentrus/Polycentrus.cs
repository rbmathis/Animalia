using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Polycentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Polycentridae.Polycentrus;

/// <summary>
/// Abstract class for Polycentrus (genus).
/// NCBI TaxId: 1206944
/// </summary>
public abstract class Polycentrus : Polycentridae, IPolycentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polycentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1206944;

    /// <inheritdoc />
    public virtual string GenusName => "Polycentrus";

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
