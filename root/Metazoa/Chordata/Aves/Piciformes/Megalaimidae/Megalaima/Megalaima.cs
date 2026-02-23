using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Megalaimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Megalaimidae.Megalaima;

/// <summary>
/// Abstract class for Megalaima (genus).
/// NCBI TaxId: 91772
/// </summary>
public abstract class Megalaima : Megalaimidae, IMegalaima
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalaima";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91772;

    /// <inheritdoc />
    public virtual string GenusName => "Megalaima";

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
