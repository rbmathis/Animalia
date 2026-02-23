using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Cnemidocarpa;

/// <summary>
/// Abstract class for Cnemidocarpa (genus).
/// NCBI TaxId: 30292
/// </summary>
public abstract class Cnemidocarpa : Styelidae, ICnemidocarpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cnemidocarpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30292;

    /// <inheritdoc />
    public virtual string GenusName => "Cnemidocarpa";

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
