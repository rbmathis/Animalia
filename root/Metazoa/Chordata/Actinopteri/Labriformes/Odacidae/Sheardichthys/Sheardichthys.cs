using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae.Sheardichthys;

/// <summary>
/// Abstract class for Sheardichthys (genus).
/// NCBI TaxId: 2986118
/// </summary>
public abstract class Sheardichthys : Odacidae, ISheardichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sheardichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2986118;

    /// <inheritdoc />
    public virtual string GenusName => "Sheardichthys";

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
