using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Pycnochromis;

/// <summary>
/// Abstract class for Pycnochromis (genus).
/// NCBI TaxId: 2891203
/// </summary>
public abstract class Pycnochromis : Pomacentridae, IPycnochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pycnochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2891203;

    /// <inheritdoc />
    public virtual string GenusName => "Pycnochromis";

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
