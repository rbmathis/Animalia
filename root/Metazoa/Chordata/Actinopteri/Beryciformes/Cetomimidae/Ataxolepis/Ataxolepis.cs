using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Ataxolepis;

/// <summary>
/// Abstract class for Ataxolepis (genus).
/// NCBI TaxId: 565088
/// </summary>
public abstract class Ataxolepis : Cetomimidae, IAtaxolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ataxolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 565088;

    /// <inheritdoc />
    public virtual string GenusName => "Ataxolepis";

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
