using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Dacelo;

/// <summary>
/// Abstract class for Dacelo (genus).
/// NCBI TaxId: 8938
/// </summary>
public abstract class Dacelo : Alcedinidae, IDacelo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dacelo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8938;

    /// <inheritdoc />
    public virtual string GenusName => "Dacelo";

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
