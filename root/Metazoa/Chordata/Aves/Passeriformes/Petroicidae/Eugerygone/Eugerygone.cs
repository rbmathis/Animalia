using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Eugerygone;

/// <summary>
/// Abstract class for Eugerygone (genus).
/// NCBI TaxId: 254535
/// </summary>
public abstract class Eugerygone : Petroicidae, IEugerygone
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eugerygone";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254535;

    /// <inheritdoc />
    public virtual string GenusName => "Eugerygone";

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
