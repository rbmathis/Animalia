using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Aethaloperca;

/// <summary>
/// Abstract class for Aethaloperca (genus).
/// NCBI TaxId: 327775
/// </summary>
public abstract class Aethaloperca : Serranidae, IAethaloperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aethaloperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 327775;

    /// <inheritdoc />
    public virtual string GenusName => "Aethaloperca";

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
