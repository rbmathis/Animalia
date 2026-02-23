using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Pygopristis;

/// <summary>
/// Abstract class for Pygopristis (genus).
/// NCBI TaxId: 442392
/// </summary>
public abstract class Pygopristis : Serrasalmidae, IPygopristis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pygopristis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 442392;

    /// <inheritdoc />
    public virtual string GenusName => "Pygopristis";

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
