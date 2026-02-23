using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Cyanerpes;

/// <summary>
/// Abstract class for Cyanerpes (genus).
/// NCBI TaxId: 62184
/// </summary>
public abstract class Cyanerpes : Fringillidae, ICyanerpes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanerpes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62184;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanerpes";

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
