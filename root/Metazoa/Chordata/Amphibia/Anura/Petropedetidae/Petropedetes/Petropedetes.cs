using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Petropedetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Petropedetidae.Petropedetes;

/// <summary>
/// Abstract class for Petropedetes (genus).
/// NCBI TaxId: 111092
/// </summary>
public abstract class Petropedetes : Petropedetidae, IPetropedetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petropedetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111092;

    /// <inheritdoc />
    public virtual string GenusName => "Petropedetes";

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
