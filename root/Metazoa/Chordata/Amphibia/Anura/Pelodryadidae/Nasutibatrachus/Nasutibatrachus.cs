using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Nasutibatrachus;

/// <summary>
/// Abstract class for Nasutibatrachus (genus).
/// NCBI TaxId: 3681001
/// </summary>
public abstract class Nasutibatrachus : Pelodryadidae, INasutibatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nasutibatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3681001;

    /// <inheritdoc />
    public virtual string GenusName => "Nasutibatrachus";

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
