using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Discocheilus;

/// <summary>
/// Abstract class for Discocheilus (genus).
/// NCBI TaxId: 887916
/// </summary>
public abstract class Discocheilus : Cyprinidae, IDiscocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Discocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 887916;

    /// <inheritdoc />
    public virtual string GenusName => "Discocheilus";

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
