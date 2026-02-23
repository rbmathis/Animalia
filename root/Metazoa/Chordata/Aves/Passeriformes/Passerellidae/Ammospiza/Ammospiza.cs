using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Ammospiza;

/// <summary>
/// Abstract class for Ammospiza (genus).
/// NCBI TaxId: 2517974
/// </summary>
public abstract class Ammospiza : Passerellidae, IAmmospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2517974;

    /// <inheritdoc />
    public virtual string GenusName => "Ammospiza";

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
