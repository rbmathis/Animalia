using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae.Lethotremus;

/// <summary>
/// Abstract class for Lethotremus (genus).
/// NCBI TaxId: 1302290
/// </summary>
public abstract class Lethotremus : Cyclopteridae, ILethotremus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lethotremus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1302290;

    /// <inheritdoc />
    public virtual string GenusName => "Lethotremus";

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
