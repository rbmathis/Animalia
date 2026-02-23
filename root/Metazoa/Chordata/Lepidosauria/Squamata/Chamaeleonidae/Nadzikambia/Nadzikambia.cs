using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Nadzikambia;

/// <summary>
/// Abstract class for Nadzikambia (genus).
/// NCBI TaxId: 414972
/// </summary>
public abstract class Nadzikambia : Chamaeleonidae, INadzikambia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nadzikambia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 414972;

    /// <inheritdoc />
    public virtual string GenusName => "Nadzikambia";

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
