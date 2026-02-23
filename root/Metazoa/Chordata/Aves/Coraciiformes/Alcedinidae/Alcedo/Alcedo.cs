using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Alcedo;

/// <summary>
/// Abstract class for Alcedo (genus).
/// NCBI TaxId: 36244
/// </summary>
public abstract class Alcedo : Alcedinidae, IAlcedo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alcedo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36244;

    /// <inheritdoc />
    public virtual string GenusName => "Alcedo";

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
