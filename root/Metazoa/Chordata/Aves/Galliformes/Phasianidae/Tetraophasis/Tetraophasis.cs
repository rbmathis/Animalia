using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Tetraophasis;

/// <summary>
/// Abstract class for Tetraophasis (genus).
/// NCBI TaxId: 459759
/// </summary>
public abstract class Tetraophasis : Phasianidae, ITetraophasis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetraophasis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 459759;

    /// <inheritdoc />
    public virtual string GenusName => "Tetraophasis";

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
