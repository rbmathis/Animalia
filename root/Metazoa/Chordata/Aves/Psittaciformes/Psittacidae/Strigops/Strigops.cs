using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Strigops;

/// <summary>
/// Abstract class for Strigops (genus).
/// NCBI TaxId: 35547
/// </summary>
public abstract class Strigops : Psittacidae, IStrigops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Strigops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 35547;

    /// <inheritdoc />
    public virtual string GenusName => "Strigops";

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
