using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Colobosauroides;

/// <summary>
/// Abstract class for Colobosauroides (genus).
/// NCBI TaxId: 174745
/// </summary>
public abstract class Colobosauroides : Gymnophthalmidae, IColobosauroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colobosauroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174745;

    /// <inheritdoc />
    public virtual string GenusName => "Colobosauroides";

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
