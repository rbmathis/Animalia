using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Andinoacara;

/// <summary>
/// Abstract class for Andinoacara (genus).
/// NCBI TaxId: 933952
/// </summary>
public abstract class Andinoacara : Cichlidae, IAndinoacara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Andinoacara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 933952;

    /// <inheritdoc />
    public virtual string GenusName => "Andinoacara";

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
