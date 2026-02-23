using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Phaetusa;

/// <summary>
/// Abstract class for Phaetusa (genus).
/// NCBI TaxId: 297812
/// </summary>
public abstract class Phaetusa : Laridae, IPhaetusa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phaetusa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 297812;

    /// <inheritdoc />
    public virtual string GenusName => "Phaetusa";

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
