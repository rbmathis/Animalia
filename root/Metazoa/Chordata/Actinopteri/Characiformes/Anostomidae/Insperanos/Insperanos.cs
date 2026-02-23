using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Insperanos;

/// <summary>
/// Abstract class for Insperanos (genus).
/// NCBI TaxId: 2846957
/// </summary>
public abstract class Insperanos : Anostomidae, IInsperanos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Insperanos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2846957;

    /// <inheritdoc />
    public virtual string GenusName => "Insperanos";

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
