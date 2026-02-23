using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Recurvirostridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Recurvirostridae.Recurvirostra;

/// <summary>
/// Abstract class for Recurvirostra (genus).
/// NCBI TaxId: 171274
/// </summary>
public abstract class Recurvirostra : Recurvirostridae, IRecurvirostra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Recurvirostra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 171274;

    /// <inheritdoc />
    public virtual string GenusName => "Recurvirostra";

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
