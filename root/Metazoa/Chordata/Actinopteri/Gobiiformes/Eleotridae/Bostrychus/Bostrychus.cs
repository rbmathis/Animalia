using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Bostrychus;

/// <summary>
/// Abstract class for Bostrychus (genus).
/// NCBI TaxId: 86223
/// </summary>
public abstract class Bostrychus : Eleotridae, IBostrychus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bostrychus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86223;

    /// <inheritdoc />
    public virtual string GenusName => "Bostrychus";

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
