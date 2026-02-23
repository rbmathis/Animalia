using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Pachytriton;

/// <summary>
/// Abstract class for Pachytriton (genus).
/// NCBI TaxId: 156858
/// </summary>
public abstract class Pachytriton : Salamandridae, IPachytriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachytriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156858;

    /// <inheritdoc />
    public virtual string GenusName => "Pachytriton";

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
