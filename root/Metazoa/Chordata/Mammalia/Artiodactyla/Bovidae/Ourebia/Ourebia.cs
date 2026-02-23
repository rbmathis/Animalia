using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Ourebia;

/// <summary>
/// Abstract class for Ourebia (genus).
/// NCBI TaxId: 59535
/// </summary>
public abstract class Ourebia : Bovidae, IOurebia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ourebia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59535;

    /// <inheritdoc />
    public virtual string GenusName => "Ourebia";

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
