using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Cynisca;

/// <summary>
/// Abstract class for Cynisca (genus).
/// NCBI TaxId: 261483
/// </summary>
public abstract class Cynisca : Amphisbaenidae, ICynisca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cynisca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 261483;

    /// <inheritdoc />
    public virtual string GenusName => "Cynisca";

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
