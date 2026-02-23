using AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Falco;

/// <summary>
/// Abstract class for Falco (genus).
/// NCBI TaxId: 8952
/// </summary>
public abstract class Falco : Falconidae, IFalco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Falco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8952;

    /// <inheritdoc />
    public virtual string GenusName => "Falco";

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
