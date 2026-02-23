using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Mecocerculus;

/// <summary>
/// Abstract class for Mecocerculus (genus).
/// NCBI TaxId: 456375
/// </summary>
public abstract class Mecocerculus : Tyrannidae, IMecocerculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mecocerculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 456375;

    /// <inheritdoc />
    public virtual string GenusName => "Mecocerculus";

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
