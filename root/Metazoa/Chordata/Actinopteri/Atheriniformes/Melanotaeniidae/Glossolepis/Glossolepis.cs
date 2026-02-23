using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae.Glossolepis;

/// <summary>
/// Abstract class for Glossolepis (genus).
/// NCBI TaxId: 32457
/// </summary>
public abstract class Glossolepis : Melanotaeniidae, IGlossolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glossolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32457;

    /// <inheritdoc />
    public virtual string GenusName => "Glossolepis";

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
