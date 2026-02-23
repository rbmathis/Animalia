using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Anadia;

/// <summary>
/// Abstract class for Anadia (genus).
/// NCBI TaxId: 174734
/// </summary>
public abstract class Anadia : Gymnophthalmidae, IAnadia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anadia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174734;

    /// <inheritdoc />
    public virtual string GenusName => "Anadia";

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
