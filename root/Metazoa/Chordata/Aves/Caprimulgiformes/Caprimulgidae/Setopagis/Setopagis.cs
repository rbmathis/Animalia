using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Setopagis;

/// <summary>
/// Abstract class for Setopagis (genus).
/// NCBI TaxId: 1854008
/// </summary>
public abstract class Setopagis : Caprimulgidae, ISetopagis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Setopagis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1854008;

    /// <inheritdoc />
    public virtual string GenusName => "Setopagis";

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
