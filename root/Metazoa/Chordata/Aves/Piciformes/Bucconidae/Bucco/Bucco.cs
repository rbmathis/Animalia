using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Bucco;

/// <summary>
/// Abstract class for Bucco (genus).
/// NCBI TaxId: 135167
/// </summary>
public abstract class Bucco : Bucconidae, IBucco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bucco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135167;

    /// <inheritdoc />
    public virtual string GenusName => "Bucco";

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
