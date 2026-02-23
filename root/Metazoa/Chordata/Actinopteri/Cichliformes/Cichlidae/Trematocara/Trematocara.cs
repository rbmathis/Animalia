using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Trematocara;

/// <summary>
/// Abstract class for Trematocara (genus).
/// NCBI TaxId: 158781
/// </summary>
public abstract class Trematocara : Cichlidae, ITrematocara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trematocara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 158781;

    /// <inheritdoc />
    public virtual string GenusName => "Trematocara";

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
