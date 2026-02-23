using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Gymnobucco;

/// <summary>
/// Abstract class for Gymnobucco (genus).
/// NCBI TaxId: 240718
/// </summary>
public abstract class Gymnobucco : Lybiidae, IGymnobucco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnobucco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240718;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnobucco";

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
