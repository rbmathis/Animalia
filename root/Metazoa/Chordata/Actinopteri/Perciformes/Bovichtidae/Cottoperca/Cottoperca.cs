using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bovichtidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bovichtidae.Cottoperca;

/// <summary>
/// Abstract class for Cottoperca (genus).
/// NCBI TaxId: 56715
/// </summary>
public abstract class Cottoperca : Bovichtidae, ICottoperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cottoperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56715;

    /// <inheritdoc />
    public virtual string GenusName => "Cottoperca";

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
