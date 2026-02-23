using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Polycentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Polycentridae.Polycentropsis;

/// <summary>
/// Abstract class for Polycentropsis (genus).
/// NCBI TaxId: 302774
/// </summary>
public abstract class Polycentropsis : Polycentridae, IPolycentropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polycentropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 302774;

    /// <inheritdoc />
    public virtual string GenusName => "Polycentropsis";

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
