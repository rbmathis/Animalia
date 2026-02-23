using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Polysteganus;

/// <summary>
/// Abstract class for Polysteganus (genus).
/// NCBI TaxId: 119735
/// </summary>
public abstract class Polysteganus : Sparidae, IPolysteganus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polysteganus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119735;

    /// <inheritdoc />
    public virtual string GenusName => "Polysteganus";

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
