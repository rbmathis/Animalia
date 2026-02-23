using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Epapterus;

/// <summary>
/// Abstract class for Epapterus (genus).
/// NCBI TaxId: 337681
/// </summary>
public abstract class Epapterus : Auchenipteridae, IEpapterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epapterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337681;

    /// <inheritdoc />
    public virtual string GenusName => "Epapterus";

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
