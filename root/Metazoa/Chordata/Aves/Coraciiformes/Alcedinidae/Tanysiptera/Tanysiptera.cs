using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Tanysiptera;

/// <summary>
/// Abstract class for Tanysiptera (genus).
/// NCBI TaxId: 342386
/// </summary>
public abstract class Tanysiptera : Alcedinidae, ITanysiptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tanysiptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 342386;

    /// <inheritdoc />
    public virtual string GenusName => "Tanysiptera";

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
