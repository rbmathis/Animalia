using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Noturus;

/// <summary>
/// Abstract class for Noturus (genus).
/// NCBI TaxId: 61322
/// </summary>
public abstract class Noturus : Ictaluridae, INoturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Noturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61322;

    /// <inheritdoc />
    public virtual string GenusName => "Noturus";

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
