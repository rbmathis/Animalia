using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dipsadoboa;

/// <summary>
/// Abstract class for Dipsadoboa (genus).
/// NCBI TaxId: 186580
/// </summary>
public abstract class Dipsadoboa : Colubridae, IDipsadoboa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dipsadoboa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186580;

    /// <inheritdoc />
    public virtual string GenusName => "Dipsadoboa";

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
