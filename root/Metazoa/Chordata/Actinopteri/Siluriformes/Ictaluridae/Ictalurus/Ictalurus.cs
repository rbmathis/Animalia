using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Ictalurus;

/// <summary>
/// Abstract class for Ictalurus (genus).
/// NCBI TaxId: 7997
/// </summary>
public abstract class Ictalurus : Ictaluridae, IIctalurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ictalurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7997;

    /// <inheritdoc />
    public virtual string GenusName => "Ictalurus";

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
