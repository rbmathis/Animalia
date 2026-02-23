using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Cionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Cionidae.Rophalaea;

/// <summary>
/// Abstract class for Rophalaea (genus).
/// NCBI TaxId: 286204
/// </summary>
public abstract class Rophalaea : Cionidae, IRophalaea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rophalaea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286204;

    /// <inheritdoc />
    public virtual string GenusName => "Rophalaea";

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
