using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Lerwa;

/// <summary>
/// Abstract class for Lerwa (genus).
/// NCBI TaxId: 1756203
/// </summary>
public abstract class Lerwa : Phasianidae, ILerwa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lerwa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1756203;

    /// <inheritdoc />
    public virtual string GenusName => "Lerwa";

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
