using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Anguiculus;

/// <summary>
/// Abstract class for Anguiculus (genus).
/// NCBI TaxId: 3404850
/// </summary>
public abstract class Anguiculus : Colubridae, IAnguiculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anguiculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3404850;

    /// <inheritdoc />
    public virtual string GenusName => "Anguiculus";

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
