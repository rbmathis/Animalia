using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Potamites;

/// <summary>
/// Abstract class for Potamites (genus).
/// NCBI TaxId: 1333665
/// </summary>
public abstract class Potamites : Gymnophthalmidae, IPotamites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Potamites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1333665;

    /// <inheritdoc />
    public virtual string GenusName => "Potamites";

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
