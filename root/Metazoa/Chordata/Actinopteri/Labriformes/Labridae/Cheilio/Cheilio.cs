using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Cheilio;

/// <summary>
/// Abstract class for Cheilio (genus).
/// NCBI TaxId: 241272
/// </summary>
public abstract class Cheilio : Labridae, ICheilio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheilio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241272;

    /// <inheritdoc />
    public virtual string GenusName => "Cheilio";

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
