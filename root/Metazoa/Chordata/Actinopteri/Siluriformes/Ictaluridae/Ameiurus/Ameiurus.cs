using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Ameiurus;

/// <summary>
/// Abstract class for Ameiurus (genus).
/// NCBI TaxId: 50384
/// </summary>
public abstract class Ameiurus : Ictaluridae, IAmeiurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ameiurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50384;

    /// <inheritdoc />
    public virtual string GenusName => "Ameiurus";

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
